class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
      return new int[] {0, 2, 5, 3, 7, 8, 4};
    }

    public int Today()
    {
      int lastIndex = birdsPerDay.Length - 1;
      return birdsPerDay[lastIndex];
    }

    public void IncrementTodaysCount()
    {
      int lastIndex = birdsPerDay.Length - 1;
       birdsPerDay[lastIndex] = birdsPerDay[lastIndex] + 1;
    }

    public bool HasDayWithoutBirds()
    {
        var NoBirds = false;
        foreach(var birds in birdsPerDay){
            if(birds == 0){
                NoBirds = true;
            }
        }
        return NoBirds;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        var BirdsCountForDays= 0;
        for(var i=0; i <= numberOfDays - 1; i++ ){
            BirdsCountForDays += birdsPerDay[i];
        }
        return BirdsCountForDays;
    }

    public int BusyDays()
    {
        var busyDays = 0;
        foreach(var birds in birdsPerDay){
            if(birds >= 5){
                busyDays ++;
            }
        }
        return busyDays;
    }
    
}
