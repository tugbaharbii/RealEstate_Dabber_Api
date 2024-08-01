using RealEstate_Dabber_Api.Dtos.MessageDtos;

namespace RealEstate_Dabber_Api.Repositories.MessageRepositories
{
	public interface IMessageRepository
	{
		Task<List<ResultInBoxMessageDto>> GetInBoxLast3MessageListByReceiver(int id);
	}
}
