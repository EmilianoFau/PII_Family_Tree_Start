namespace Library;

public interface NodeOperations
{
    void Accept (TotalAgeVisitor visitor);
    void Accept (OldestVisitor visitor);
}