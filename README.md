

# Palindromes TDD

  

### Created by Sarah Gilbert, Bess Campbell, and Tawnee Harris 

  

## Description

  

##### This backend project was created so we could practice using TDD with C#. In this project we created and tested code for a console application that includes a method to identify whether a word is a palindrome or not. A palindrome is any word, phrase, number, or other sequence of characters that reads the same both backward or forward. It should return true if the user-provided word is a palindrome and false if it is not.

  
  

## Specifications

  

| Test | Input | Output |

| :-------------------- | :------------------------------------- | :-------------------------- |
|.char[] Methods|||
|Should correctly take a word and break it up into individual strings of characters in an array | ("hello") | ("h", "e", "l", "l", "o") |
|Array.Reverse() Methods|||
|Should correctly take the array of stringed characters and reverse their order.| ("h", "e", "l", "l", "o") | ("o", "l", "l", "e", "h") |
|Should correctly take the reversed array and save it as a new string. |("o", "l", "l", "e", "h") | ("olleh") |
|.Equals Methods|||
|Should correctly take the new string and see if it equals to the original word. | ("olleh").Equals("hello") | False |
|Should correctly take the new string and see if it equals to the original word. | ("racecar").Equals("racecar") | True |
  

## Setup Instruction

  

#### View Online

  

* Follow this link https://sarahgilbert064.github.io/Palindromes/

  

#### Open Locally

  

1. Navigate to https://github.com/SarahGilbert064/Palindromes

  

2. Click on the green "Code" button and copy the repository HTTPS URL

  

3. Open your machine terminal and use the command 'git clone https://github.com/SarahGilbert064/Palindromes in the directory you would like to clone the repository

  

4. Another option is to click "Download Zip" and open the file on your machine.

  

## Known Bugs

#### No known bugs

  

## Support and Contact Details

* Contact me at sarahgilbert064@gmail.com

  

## Technologies Used

* HTML

* CSS

* JavaScript

* JQuery

* Visual Studio Code

* Jest

* esLint

* Babel

  

## Legal

#### Copyright (c) 2020 Sarah Gilbert

#### This software is licensed under the MIT license