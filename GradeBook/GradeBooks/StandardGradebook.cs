using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradebook : BaseGradeBook
    {
        public StandardGradebook(string name , bool isWeighted) : base(name, isWeighted)
        {
            Type = GradeBookType.Standard;
        }
    }
}
