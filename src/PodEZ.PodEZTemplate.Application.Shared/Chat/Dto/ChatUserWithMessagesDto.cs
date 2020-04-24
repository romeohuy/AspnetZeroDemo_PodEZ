using System.Collections.Generic;

namespace PodEZ.PodEZTemplate.Chat.Dto
{
    public class ChatUserWithMessagesDto : ChatUserDto
    {
        public List<ChatMessageDto> Messages { get; set; }
    }
}