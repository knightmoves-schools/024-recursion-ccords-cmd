namespace knightmoves;
public class ToDo
{
    public string[] MarkAsDone(string[] todos)
    {
        string[] result = new string[todos.Length];
        for (int i = 0; i < todos.Length; i++)
        {
            result[i] = "done - " + todos[i];
        }
        return result;
    }
}
