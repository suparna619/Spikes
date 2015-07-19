namespace Sorting
{
    public interface IMyComparable<TComparable>
    {
        int CompareTo(TComparable otherComparable);
    }
}