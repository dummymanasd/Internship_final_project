namespace Internship2024.Model
{
    public interface IAreaCreateRepository
    {
        void CreateArea(AreaCreate create);
        string GetUniqueCodeFromDatabase();
    }
}