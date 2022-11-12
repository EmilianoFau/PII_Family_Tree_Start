namespace Library;

public interface PersonOperations : NodeOperations
{
    void Accept (LargestVisitor visitor);
}