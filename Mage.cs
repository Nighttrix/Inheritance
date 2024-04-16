class Mage : Pupil {
    //CONSTRUCTOR 
    public Mage(string title) : base(title) {
        
    }

    //METHODS
    public virtual Storm CastRainStorm() {
        return new Storm("rain", false, Title);
    }

    
}