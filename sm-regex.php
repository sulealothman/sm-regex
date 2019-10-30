<?php

/**
 *
 * Author Suleiman Al-Othman (@sulealothman)
 * Regular Expression of Social Media Accounts
 * Matched for username Github, Twitter, Instagram and Snapchat
 *
 **/

$username = "sulealothman";


function check_pattern($pattern, $text) {
    if(preg_match($pattern, $text))
        return "Yes, is matched";
    return "No, is not matched";
}

$gitPattern = '/^(?!.*\-\-|.*\-$|.*\_)[a-zA-Z0-9][\w-]+[a-zA-Z0-9]{0,39}$/';
$twitterPattern = '/^[A-z0-9]{0,15}$/';
$instaPattern = '/^(?!.*\.\.|.*\.$)[A-z0-9][\w.]+[A-z0-9]{0,30}$/';
$snapPattern = '/^(?!.*\.\.|.*\_\_|.*\-\-)(?!.*\.$|.*\_$|.*\-$)(?!.*\.\-|.*\-\.|.*\-\_|.*\_\-|.*\.\_|.*\_\.)[a-zA-Z]+[\w.-][0-9A-z]{0,15}$/';


$patterns = [
    'Github' => '/^(?!.*\-\-|.*\-$|.*\_)[a-zA-Z0-9][\w-]+[a-zA-Z0-9]{0,39}$/',
    'Twitter' => '/^[A-z0-9]{0,15}$/',
    'Instagram' => '/^(?!.*\.\.|.*\.$)[A-z0-9][\w.]+[A-z0-9]{0,30}$/',
    'Snapchat' => '/^(?!.*\.\.|.*\_\_|.*\-\-)(?!.*\.$|.*\_$|.*\-$)(?!.*\.\-|.*\-\.|.*\-\_|.*\_\-|.*\.\_|.*\_\.)[a-zA-Z]+[\w.-][0-9A-z]{0,15}$/'
];


foreach ($patterns as $patternName => $pattern):
    echo $patternName .' : ' . check_pattern($pattern, $username) . '<br />';
endforeach;

