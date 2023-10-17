public class Word 
{
    private List<int> _hiddenWords;

    public Word() {
        _hiddenWords = new List<int>();
    }

    public void SetToList(int index) {
        
        _hiddenWords.Add(index);
    }

    public List<int> GetList(){
        return _hiddenWords;
    }


}