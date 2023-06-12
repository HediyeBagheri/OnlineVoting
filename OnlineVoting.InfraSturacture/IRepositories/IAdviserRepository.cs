using OnlineVoting.Model;

public interface IAdviserRepository
{
    IQueryable<Adviser> GetAll();
    int Add(Adviser adviser);
    int Delete(int id);
    IQueryable<Adviser> Search(string keyword);
}
