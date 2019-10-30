#!/usr/bin/ruby -w

=begin
 * Author Suleiman Al-Othman (@sulealothman)
 * Regular Expression of Social Media Accounts
 * Matched for username Github, Twitter, Instagram and Snapchat
=end


patterns = {
    'Github' => /^(?!.*\-\-|.*\-$|.*\_)[a-zA-Z0-9][\w-]+[a-zA-Z0-9]{0,39}$/i,
    'Twitter' => /^[A-z0-9]{0,15}$/i,
    'Instagram' => /^(?!.*\.\.|.*\.$)[A-z0-9][\w.]+[A-z0-9]{0,30}$/i,
    'Snapchat' => /^(?!.*\.\.|.*\_\_|.*\-\-)(?!.*\.$|.*\_$|.*\-$)(?!.*\.\-|.*\-\.|.*\-\_|.*\_\-|.*\.\_|.*\_\.)[a-zA-Z]+[\w.-][0-9A-z]{0,15}$/i
}

def check_pattern(pattern, text)
	if text.match?(pattern) then return "Yes, is matched" end
	return "No, is not matched"
end

puts "Enter your yourname : "
username = gets

patterns.each{|key, value| puts "#{key} : #{check_pattern(value, username)}" }