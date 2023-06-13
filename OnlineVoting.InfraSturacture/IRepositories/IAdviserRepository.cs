using OnlineVoting.Model;

public interface IAdviserRepository
{
    IQueryable<Adviser> GetAll();
    bool Add(Adviser adviser);
    bool Update(int id, Adviser adviser);
    int Delete(int id);
    IQueryable<Adviser> Search(string keyword);
}
