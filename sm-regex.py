import re

# Author Suleiman Al-Othman (@sulealothman)
# Regular Expression of Social Media Accounts
# Matched for username Github, Twitter, Instagram and Snapchat

patterns = {
	'Github' : r'^(?!.*\-\-|.*\-$|.*\_)[a-zA-Z0-9][\w-]+[a-zA-Z0-9]{0,39}$',
	'Twitter' : r'^[A-z0-9]{0,15}$',
	'Instagram' : r'^(?!.*\.\.|.*\.$)[A-z0-9][\w.]+[A-z0-9]{0,30}$',
	'Snapchat' : r'^(?!.*\.\.|.*\_\_|.*\-\-)(?!.*\.$|.*\_$|.*\-$)(?!.*\.\-|.*\-\.|.*\-\_|.*\_\-|.*\.\_|.*\_\.)[a-zA-Z]+[\w.-][0-9A-z]{0,15}$'
}


def check_pattern(pattern, text):
	if(re.match(pattern, text)):
		return "Yes, is matched ."
	return "No, is not matched ."


user = input("Enter your username: ")

for appName, pattern in patterns.items():
	print(appName, ' : ', check_pattern(pattern, user))