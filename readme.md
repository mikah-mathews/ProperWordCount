# Word Counter Application

## by Mikah Mathews (2020)

## Description

This app will allow a user to input a word, then a sentence, then see how many instances of that word there is.

## Setup

Install .NET, type "dotnet run" in your terminal while within the project directory. Enjoy.

## Technology

#### C#
#### .NET
#### MSTest

## Specs

|Behavior|Input|Output|
|-----|-----|-----|
|Program will accept word to look for from user| Cat| Cat|
|Program will accept sentence to see if the word is in it|Look at that cat|Look at that cat|
|Program will set word occurance to zero|wordOccurance = 0|wordOccurance = 0|
|Program will separate word into a letters array so program can check sentence words length and see if it matches| Cat| ["C", "a", "t"]|
|Program will seperate sentence words into an array|[{Look} {at} {that} {cat}]|{{Look} {at} {that} {cat}}|
|Program will go through sentence array and check each word| is["C", "a", "t"] == ["L", "o", "o", "k"]|["C", "a", "t"] != ["L", "o", "o", "k"]|
|When word is matching, add one to wordOccurance |is ["C", "a", "t"] == ["C", "a", "t"] | ["C", "a", "t"] == ["C", "a", "t"] |
|Program will return word occurance|Look at that cat|word occurance = 1|



## Legal

#### MIT License

### Copyright (c) 2020 Mikah Mathews

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
