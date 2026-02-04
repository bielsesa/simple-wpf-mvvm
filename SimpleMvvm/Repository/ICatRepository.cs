using SimpleMvvm.Cat;

namespace SimpleMvvm.Repository
{
    public interface ICatRepository
    {
        CatModel[] GetAllCats();
    }
}