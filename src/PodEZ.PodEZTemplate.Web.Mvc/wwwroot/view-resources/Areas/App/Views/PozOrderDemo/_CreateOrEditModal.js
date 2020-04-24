(function ($) {
    app.modals.CreateOrEditPozOrderDemoModal = function () {

        var _pozOrderDemoService = abp.services.app.pozOrderDemo;

        var _modalManager;
        var _$pozOrderDemoInformationForm = null;

		

        this.init = function (modalManager) {
            _modalManager = modalManager;

			var modal = _modalManager.getModal();
            modal.find('.date-picker').datetimepicker({
                locale: abp.localization.currentLanguage.name,
                format: 'L'
            });

            _$pozOrderDemoInformationForm = _modalManager.getModal().find('form[name=PozOrderDemoInformationsForm]');
            _$pozOrderDemoInformationForm.validate();
        };

		  

        this.save = function () {
            if (!_$pozOrderDemoInformationForm.valid()) {
                return;
            }

            var pozOrderDemo = _$pozOrderDemoInformationForm.serializeFormToObject();
			
			 _modalManager.setBusy(true);
			 _pozOrderDemoService.createOrEdit(
				pozOrderDemo
			 ).done(function () {
               abp.notify.info(app.localize('SavedSuccessfully'));
               _modalManager.close();
               abp.event.trigger('app.createOrEditPozOrderDemoModalSaved');
			 }).always(function () {
               _modalManager.setBusy(false);
			});
        };
    };
})(jQuery);