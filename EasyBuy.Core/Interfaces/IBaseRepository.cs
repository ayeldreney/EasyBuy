namespace EasyBuy.Core.Interfaces;

public interface IBaseRepository<T> where T : class
{
	public T GetById(int id);
	public IEnumerable<T> GetAll();

	
}