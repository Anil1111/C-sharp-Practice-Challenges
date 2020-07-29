using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

public class GradeSchool {

    private Dictionary<int, List<string>> schoolRoster = new Dictionary<int, List<string>> ();
    public void Add (string student, int grade) {
        if (!schoolRoster.ContainsKey (grade))
            schoolRoster.Add (grade, new List<string> ());
        schoolRoster[grade].Add (student);
        schoolRoster[grade].Sort ();
    }

    public IEnumerable<string> Roster () {
        List<string> roster = new List<string> ();
        foreach (var grade in schoolRoster.Keys.OrderBy (x => x)) {
            roster.AddRange (schoolRoster[grade]);
        }
        return roster;
    }

    public IEnumerable<string> Grade (int grade) => schoolRoster.ContainsKey(grade)?schoolRoster[grade]:new List<string>();
}
