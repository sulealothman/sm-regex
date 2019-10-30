Regular Expressions to Match Social Media Accounts

This repository lists regular expressions to match and check is valid of social media accounts. i added examples code for PHP, Ruby, Java, Swift, C#, VBNET, Python & Javascript languages ..


Github username

PHP and Ruby

/^(?!.*\-\-|.*\-$|.*\_)[a-zA-Z0-9][\w-]+[a-zA-Z0-9]{0,39}$/

Java & Swift

^(?!.*\\-\\-|.*\\-$|.*\\_)[a-zA-Z0-9][\\w-]+[a-zA-Z0-9]{0,39}$

C# & VBNET

^(?!.*\-\-|.*\-$|.*_)[a-zA-Z0-9][\w-]+[a-zA-Z0-9]{0,39}$

Python

^(?!.*\-\-|.*\-$|.*\_)[a-zA-Z0-9][\w-]+[a-zA-Z0-9]{0,39}$

Javascript

/^(?!.*\-\-|.*\-$|.*\_)[a-zA-Z0-9][\w-]+[a-zA-Z0-9]{0,39}$/i

Rules :

    Matches with one hyphen (sule-alothman) but not consecutive hyphens (sule--alothman) but can added many hyphens between char and char (sule-al-othman).
    Starting period not matched (-sulealothman).
    Ending period not matched (sulealothman-).
    Not matched underscore (sule_alothman).
    Max characters 39 char.

Twitter username


^[A-z0-9]{0,15}$

PHP & Ruby

/^[A-z0-9]{0,15}$/

Java, Swift and Python

^[A-z0-9]{0,15}$

C# & VBNET

/^[A-z0-9_]{0,15}$/

Javascript

/^[A-z0-9]{0,15}$/i


Rules :

    Allowed for usernames are alphanumeric characters and underscores.



Instagram username

PHP and Ruby

/^(?!.*\.\.|.*\.$)[A-z0-9][\w.]+[A-z0-9]{0,30}$/

Java & Swift

^(?!.*\\.\\.|.*\\.$)[A-z0-9][\\w.]+[A-z0-9]{0,30}$

C#, VBNET & Python

^(?!.*\.\.|.*\.$)[A-z0-9][\w.]+[A-z0-9]{0,30}$

Javascript

/^(?!.*\.\.|.*\.$)[A-z0-9][\w.]+[A-z0-9]{0,30}$/i


Rules :

    Matches with one point (sule.alothman) but not consecutive points (sule..alothman) and can added many points between char and char (sule.al.othman).
    Starting period not matched (.sulealothman).
    Ending period not matched (sulealothman.).
    Match underscores (_sule_alothman_).
    Max characters 30 char.


Snapchat username

PHP and Ruby

/^(?!.*\.\.|.*\_\_|.*\-\-)(?!.*\.$|.*\_$|.*\-$)(?!.*\.\-|.*\-\.|.*\-\_|.*\_\-|.*\.\_|.*\_\.)[a-zA-Z]+[\w.-][0-9A-z]{0,15}$/

Java & Swift

^(?!.*\\.\\.|.*\\_\\_|.*\\-\\-)(?!.*\\.$|.*\\_$|.*\\-$)(?!.*\\.\\-|.*\\-\\.|.*\\-\\_|.*\\_\\-|.*\\.\\_|.*\\_\\.)[a-zA-Z]+[\\w.-][0-9A-z]{0,15}$

C# & VBNET

^(?!.*\.\.|.*__|.*\-\-)(?!.*\.$|.*_$|.*\-$)(?!.*\.\-|.*\-\.|.*\-_|.*_\-|.*\._|.*_\.)[a-zA-Z]+[\w.-][0-9A-z]{0,15}$

Python

^(?!.*\-\-|.*\-$|.*\_)[a-zA-Z0-9][\w-]+[a-zA-Z0-9]{0,39}$

Javascript

/^(?!.*\.\.|.*\_\_|.*\-\-)(?!.*\.$|.*\_$|.*\-$)(?!.*\.\-|.*\-\.|.*\-\_|.*\_\-|.*\.\_|.*\_\.)[a-zA-Z]+[\w.-][0-9A-z]{0,15}$/i


Rules :

    Matches with one symbol include in username (dot | undersocre | hyphen) (sule-alothman | sule.alothman| sule_alothman) but not consecutive symbols (sule--alothman | sule._alothman .. etc).
    Usernames must start with a letter.
    Usernames must end in a letter or number.
    Max characters 15 char.

