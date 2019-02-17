namespace BDCenterLibrary.DAL.Model
{
    public class ISBN
    {
        public virtual int Isbn { get; protected set; }
        public virtual Livro Livro { get; set; }
    }
}
