# TLC Predictor

This is a command line tool that generates session codes for the DVD version of Tender Loving Care.

## Background

[Tender Loving Care](https://en.wikipedia.org/wiki/Tender_Loving_Care_(video_game)) is an interactive movie. The way the movie plays out is determined by a huge series of questions asked to the player. 
It is very unclear and very unpredictable for the player to predict which answers have which effect on the movie. For me it got to the point
that I wanted to know what all the possible differences are in the movie. So I researched how the session codes work (the way you can restore your
session so you can pick the game up where you left off)

## How the tool works

You can simply start the tool and answer the multiple choice questions. There are 16 episodes, and 14 of these episodes contain one or more scenes that have variations. 
For each of these the tool will ask you what version you would like to see. Finally you'll get a code with 9 combinations of 2 hexadecimal values. This code can be used
as input for the dvd to get the version of the full movie played out like you choose.
