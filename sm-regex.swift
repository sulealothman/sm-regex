import UIKit

/**
*
* Author Suleiman Al-Othman (@sulealothman)
* Regular Expression of Social Media Accounts
* Matched for username Github, Twitter, Instagram and Snapchat
*
**/

let patterns = [
    "Github" : "^(?!.*\\-\\-|.*\\-$|.*\\_)[a-zA-Z0-9][\\w-]+[a-zA-Z0-9]{0,39}$",
    "Twitter" : "^[A-z0-9]{0,15}$",
    "Instagram" : "^(?!.*\\.\\.|.*\\.$)[A-z0-9][\\w.]+[A-z0-9]{0,30}$",
    "Snapchat" : "^(?!.*\\.\\.|.*\\_\\_|.*\\-\\-)(?!.*\\.$|.*\\_$|.*\\-$)(?!.*\\.\\-|.*\\-\\.|.*\\-\\_|.*\\_\\-|.*\\.\\_|.*\\_\\.)[a-zA-Z]+[\\w.-][0-9A-z]{0,15}$"
]

func check_pattern(pattern:String, text:String) -> String {
    let regex = try! NSRegularExpression(pattern: pattern, options: .caseInsensitive)
    let results = regex.firstMatch(in: text,
                                    range: NSRange(text.startIndex..., in: text))
    return (results != nil) ? "Yes, is matched" : "No, is not matched"
}
let username = "sulealothman"

for (appName, pattern) in patterns {
    print("\(appName) : \(check_pattern(pattern: pattern, text: username))")
}
