This is a simple project / class for peeking into the contents / structure of a stream 
that was created by the "BinaryFormatter" class' "Serialize" method.

In one project I was working on I found that the stream was much larger than I expected, 
and wanted to know what kind of problem might be causing it. 

I couldn't find anything online to do this (and my stack overflow question at 
http://stackoverflow.com/q/3052202/74296 got no relevant responses), so I spent a few 
hours coding to Microsoft's spec, and it seems to work!

This is simple demo code, not fit for any particular purpose, etc etc. I'm releasing it 
under the Modified (3-clause) BSD license, so you can do just about anything with it as 
long as you don't blame me when it goes wrong, and don't republish the code without at 
least mentioning me :)

A lot can be done to improve its structure and clarity (and "Analysis" output), but I 
have little motivation to clean it up at this point.

Any questions, thoughts, suggestions for improvement, please contact me!

Tao Klerks

tao@klerks.biz
