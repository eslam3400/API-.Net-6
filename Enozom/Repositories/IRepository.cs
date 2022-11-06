namespace Enozom.Repositories
{
    public interface IRepository<Model> where Model : class
    {
        List<Model> GetAll();
        Model Get(int id);
        void Add(Model entity);
        void Update(int id, Model entity);
        void Delete(int id);
        void Save();
    }
}
