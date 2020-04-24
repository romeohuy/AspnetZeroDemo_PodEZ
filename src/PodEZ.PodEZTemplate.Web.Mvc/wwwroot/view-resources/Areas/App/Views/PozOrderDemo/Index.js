(function () {
    $(function () {

        var _$pozOrderDemoTable = $('#PozOrderDemoTable');
        var _pozOrderDemoService = abp.services.app.pozOrderDemo;
		
        $('.date-picker').datetimepicker({
            locale: abp.localization.currentLanguage.name,
            format: 'L'
        });

        var _permissions = {
            create: abp.auth.hasPermission('Pages.PozOrderDemo.Create'),
            edit: abp.auth.hasPermission('Pages.PozOrderDemo.Edit'),
            'delete': abp.auth.hasPermission('Pages.PozOrderDemo.Delete')
        };

        var _createOrEditModal = new app.ModalManager({
            viewUrl: abp.appPath + 'App/PozOrderDemo/CreateOrEditModal',
            scriptUrl: abp.appPath + 'view-resources/Areas/App/Views/PozOrderDemo/_CreateOrEditModal.js',
            modalClass: 'CreateOrEditPozOrderDemoModal'
        });

		 var _viewPozOrderDemoModal = new app.ModalManager({
            viewUrl: abp.appPath + 'App/PozOrderDemo/ViewpozOrderDemoModal',
            modalClass: 'ViewPozOrderDemoModal'
        });

		
		

        var getDateFilter = function (element) {
            if (element.data("DateTimePicker").date() == null) {
                return null;
            }
            return element.data("DateTimePicker").date().format("YYYY-MM-DDT00:00:00Z"); 
        }

        var dataTable = _$pozOrderDemoTable.DataTable({
            paging: true,
            serverSide: true,
            processing: true,
            listAction: {
                ajaxFunction: _pozOrderDemoService.getAll,
                inputFilter: function () {
                    return {
					filter: $('#PozOrderDemoTableFilter').val(),
					pozOrderNameFilter: $('#PozOrderNameFilterId').val(),
					pozOrderDescriptionFilter: $('#PozOrderDescriptionFilterId').val(),
					minPozImageTotalFilter: $('#MinPozImageTotalFilterId').val(),
					maxPozImageTotalFilter: $('#MaxPozImageTotalFilterId').val()
                    };
                }
            },
            columnDefs: [
                {
                    width: 120,
                    targets: 0,
                    data: null,
                    orderable: false,
                    autoWidth: false,
                    defaultContent: '',
                    rowAction: {
                        cssClass: 'btn btn-brand dropdown-toggle',
                        text: '<i class="fa fa-cog"></i> ' + app.localize('Actions') + ' <span class="caret"></span>',
                        items: [
						{
                                text: app.localize('View'),
                                action: function (data) {
                                    _viewPozOrderDemoModal.open({ id: data.record.pozOrderDemo.id });
                                }
                        },
						{
                            text: app.localize('Edit'),
                            visible: function () {
                                return _permissions.edit;
                            },
                            action: function (data) {
                                _createOrEditModal.open({ id: data.record.pozOrderDemo.id });
                            }
                        }, 
						{
                            text: app.localize('Delete'),
                            visible: function () {
                                return _permissions.delete;
                            },
                            action: function (data) {
                                deletePozOrderDemo(data.record.pozOrderDemo);
                            }
                        }]
                    }
                },
					{
						targets: 1,
						 data: "pozOrderDemo.pozOrderName",
						 name: "pozOrderName"   
					},
					{
						targets: 2,
						 data: "pozOrderDemo.pozOrderDescription",
						 name: "pozOrderDescription"   
					},
					{
						targets: 3,
						 data: "pozOrderDemo.pozImageTotal",
						 name: "pozImageTotal"   
					}
            ]
        });

        function getPozOrderDemo() {
            dataTable.ajax.reload();
        }

        function deletePozOrderDemo(pozOrderDemo) {
            abp.message.confirm(
                '',
                app.localize('AreYouSure'),
                function (isConfirmed) {
                    if (isConfirmed) {
                        _pozOrderDemoService.delete({
                            id: pozOrderDemo.id
                        }).done(function () {
                            getPozOrderDemo(true);
                            abp.notify.success(app.localize('SuccessfullyDeleted'));
                        });
                    }
                }
            );
        }

		$('#ShowAdvancedFiltersSpan').click(function () {
            $('#ShowAdvancedFiltersSpan').hide();
            $('#HideAdvancedFiltersSpan').show();
            $('#AdvacedAuditFiltersArea').slideDown();
        });

        $('#HideAdvancedFiltersSpan').click(function () {
            $('#HideAdvancedFiltersSpan').hide();
            $('#ShowAdvancedFiltersSpan').show();
            $('#AdvacedAuditFiltersArea').slideUp();
        });

        $('#CreateNewPozOrderDemoButton').click(function () {
            _createOrEditModal.open();
        });

		$('#ExportToExcelButton').click(function () {
            _pozOrderDemoService
                .getPozOrderDemoToExcel({
				filter : $('#PozOrderDemoTableFilter').val(),
					pozOrderNameFilter: $('#PozOrderNameFilterId').val(),
					pozOrderDescriptionFilter: $('#PozOrderDescriptionFilterId').val(),
					minPozImageTotalFilter: $('#MinPozImageTotalFilterId').val(),
					maxPozImageTotalFilter: $('#MaxPozImageTotalFilterId').val()
				})
                .done(function (result) {
                    app.downloadTempFile(result);
                });
        });

        abp.event.on('app.createOrEditPozOrderDemoModalSaved', function () {
            getPozOrderDemo();
        });

		$('#GetPozOrderDemoButton').click(function (e) {
            e.preventDefault();
            getPozOrderDemo();
        });

		$(document).keypress(function(e) {
		  if(e.which === 13) {
			getPozOrderDemo();
		  }
		});
    });
})();