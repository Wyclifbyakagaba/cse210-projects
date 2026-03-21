class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    public string Display()
    {
        return $"{_date} - {_prompt}\n{_response}";
    }
}