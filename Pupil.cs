class Pupil {
    //PROPERTIES
    public string Title
    {get; private set;}

    //CONSTRUCTOR
    public Pupil(string title) {
        Title = title;
    }

    //METHODS
    public Storm CastWindStorm() {
        return new Storm("wind", false, Title);
    }
}