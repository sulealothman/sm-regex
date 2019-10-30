package sm.regex;
import java.util.HashMap;
import java.util.Scanner;
import java.util.regex.*;  
/**
 *
 * Author Suleiman Al-Othman (@sulealothman)
 * Regular Expression of Social Media Accounts
 * Matched for username Github, Twitter, Instagram and Snapchat
 *
 **/
public class SmRegex {
    public static void main(String[] args) {
        HashMap<String, String> patterns = new HashMap<>();
        patterns.put("Github", "^(?!.*\\-\\-|.*\\-$|.*\\_)[a-zA-Z0-9][\\w-]+[a-zA-Z0-9]{0,39}$");
        patterns.put("Twitter", "^[A-z0-9]{0,15}$");
        patterns.put("Instagram", "^(?!.*\\.\\.|.*\\.$)[A-z0-9][\\w.]+[A-z0-9]{0,30}$");
        patterns.put("Snapchat", "^(?!.*\\.\\.|.*\\_\\_|.*\\-\\-)(?!.*\\.$|.*\\_$|.*\\-$)(?!.*\\.\\-|.*\\-\\.|.*\\-\\_|.*\\_\\-|.*\\.\\_|.*\\_\\.)[a-zA-Z]+[\\w.-][0-9A-z]{0,15}$");
        
        System.out.print("Enter your username : ");
        Scanner input = new Scanner(System.in);
        String username = input.next();
        
        patterns.forEach((key, value) -> System.out.println(key + " : " + check_pattern(value,username)));
        
    }
    
    public static String check_pattern(String pattern, String text) {
        return Pattern.matches(pattern, text) ? "Yes, is matched" : "No, is not matched";
    }
    
}