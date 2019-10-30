Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Text.RegularExpressions

 ' Author Suleiman Al-Othman (@sulealothman)
 ' Regular Expression of Social Media Accounts
 ' Matched for username Github, Twitter, Instagram and Snapchat

Module sm_regex
    Public Sub Main()
        Dim patterns As New Dictionary(Of String, String)
        patterns.Add("Github", "^(?!.*\-\-|.*\-$|.*_)[a-zA-Z0-9][\w-]+[a-zA-Z0-9]{0,39}$")
        patterns.Add("Twitter", "^[A-z0-9_]{0,15}$")
        patterns.Add("Instagram", "^(?!.*\.\.|.*\.$)[A-z0-9][\w.]+[A-z0-9]{0,30}$")
        patterns.Add("Snapchat", "^(?!.*\.\.|.*__|.*\-\-)(?!.*\.$|.*_$|.*\-$)(?!.*\.\-|.*\-\.|.*\-_|.*_\-|.*\._|.*_\.)[a-zA-Z]+[\w.-][0-9A-z]{0,15}$")

        Console.Write("Enter your username : ")
        Dim username As String = Console.ReadLine()

        Dim pair As KeyValuePair(Of String, String)
        For Each pair In patterns
            Console.WriteLine("{0} : {1}", pair.Key, check_pattern(pair.Value, username))
        Next
        Console.ReadKey()
    End Sub

    Function check_pattern(ByVal pattern As String, ByVal text As String) As String
        Return If(New Regex(pattern, RegexOptions.IgnoreCase).IsMatch(text), "Yes is matched", "No, is not matched")
    End Function


End Module
