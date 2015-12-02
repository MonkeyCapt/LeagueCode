using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Info
{
    public string standingsBeforePlayoffs { get; set; }
    public string standingsAfterPlayoffs { get; set; }
    public string wins { get; set; }
    public string loses { get; set; }
    public string group { get; set; }
    public string standingInGroups { get; set; }
    public string regionalQualifier { get; set; }
}

public class Team
{
    public string name { get; set; }
    public string id { get; set; }
    public Info info { get; set; }
}

public class Teams
{
    public List<Team> team { get; set; }
}

public class NorthAmerica
{
    public Teams Teams { get; set; }
}

public class Info2
{
    public string standingsBeforePlayoffs { get; set; }
    public string standingsAfterPlayoffs { get; set; }
    public string wins { get; set; }
    public string loses { get; set; }
    public string group { get; set; }
    public string standingInGroups { get; set; }
    public string regionalQualifier { get; set; }
}

public class Team2
{
    public string name { get; set; }
    public string id { get; set; }
    public Info2 info { get; set; }
}

public class Teams2
{
    public List<Team2> team { get; set; }
}

public class Europe
{
    public Teams2 Teams { get; set; }
}

public class Info3
{
    public string standingsBeforePlayoffs { get; set; }
    public string standingsAfterPlayoffs { get; set; }
    public string regionalQualifier { get; set; }
    public string wins { get; set; }
    public string loses { get; set; }
    public string ties { get; set; }
    public string group { get; set; }
    public string standingInGroups { get; set; }
}

public class Team3
{
    public string name { get; set; }
    public string id { get; set; }
    public Info3 info { get; set; }
}

public class Teams3
{
    public List<Team3> team { get; set; }
}

public class China
{
    public Teams3 Teams { get; set; }
}

public class Info4
{
    public string standingsBeforePlayoffs { get; set; }
    public string standingsAfterPlayoffs { get; set; }
    public string wins { get; set; }
    public string loses { get; set; }
    public string group { get; set; }
    public string standingInGroups { get; set; }
    public string regionalQualifier { get; set; }
}

public class Team4
{
    public string name { get; set; }
    public string id { get; set; }
    public Info4 info { get; set; }
}

public class Teams4
{
    public List<Team4> team { get; set; }
}

public class SouthKorea
{
    public Teams4 Teams { get; set; }
}

public class Info5
{
    public string standingsBeforePlayoffs { get; set; }
    public string standingsAfterPlayoffs { get; set; }
    public string wins { get; set; }
    public string loses { get; set; }
    public string ties { get; set; }
    public string group { get; set; }
    public string standingInGroups { get; set; }
    public string regionalQualifier { get; set; }
}

public class Team5
{
    public string name { get; set; }
    public string id { get; set; }
    public Info5 info { get; set; }
}

public class Teams5
{
    public List<Team5> team { get; set; }
}

public class Taiwan
{
    public Teams5 Teams { get; set; }
}

public class Info6
{
    public string standingsBeforePlayoffs { get; set; }
    public string standingsAfterPlayoffs { get; set; }
    public string wins { get; set; }
    public string loses { get; set; }
    public string group { get; set; }
    public string standingInGroups { get; set; }
}

public class Team6
{
    public string name { get; set; }
public string id { get; set; }
    public Info6 info { get; set; }
}

public class Teams6
{
    public List<Team6> team { get; set; }
}

public class WildCard
{
    public Teams6 Teams { get; set; }
}

public class Region
{
    public NorthAmerica NorthAmerica { get; set; }
    public Europe Europe { get; set; }
    public China China { get; set; }
    public SouthKorea SouthKorea { get; set; }
    public Taiwan Taiwan { get; set; }
    public WildCard WildCard { get; set; }
}

public class League
{
    public Region Region { get; set; }
}

public class RootObject
{
    public League League { get; set; }
