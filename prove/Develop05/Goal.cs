using System.ComponentModel;

class Goal
{
    private string _shortName;
    private string _description;
    private int _points;
    
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description; 
        _points = points;
    }
    
    public virtual void RecordEvent()
    {
        
    }
    
    public virtual bool IsComplete()
    {
        return false; 
    }
    
    public virtual string GetDetailsString()
    {
       return $"{_shortName}: {_description} - {_points} Points";
    }
    
    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}: {_description} - {_points} Points";
    }

      public static Goal CreateGoalFromRepresentation(string representation)
    {
        string[] parts = representation.Split(':');
        string[] details = parts[1].Split(',');

        string typeName = parts[0];
        string shortName = details[0];
        string description = details[1];
        int points = int.Parse(details[2]);

        switch (typeName)
        {
            case "SimpleGoal":
                return new SimpleGoal(shortName, description, points);
            case "EternalGoal":
                return new EternalGoal(shortName, description, points);
            default:
                throw new ArgumentException("Invalid goal type");
        }
    }   
}