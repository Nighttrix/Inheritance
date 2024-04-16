class Archmage : Mage {
    //CONSTRUCTOR
    public Archmage(string title) : base(title) {
        
    }

    //METHODS
    public override Storm CastRainStorm() {
        return new Storm("rain", true, Title);
    }

    public Storm CastLightningStorm() {
        return new Storm("lightning", true, Title);
    }
}