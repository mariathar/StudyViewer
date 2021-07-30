using StudyViewer.Models;

namespace StudyViewer.Services
{
	public interface IUserService
	{
		object Authenticate(AuthenticateRequest model);
		object GetById(int userId);
	}
}
