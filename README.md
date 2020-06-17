# PIPCompanion

*This is a work in progress to make me understand more about WPF and solving an annoying issue of mine*

# What is this?
A little desktop companion to help me watch videos while doing other stuff

# Why?
We all do stuff. Sometimes, we do multiple stuff at the same time. Although I have 2 monitors, 
sometimes I want to have a little video playing while I use the full potential that a screen can provide. 
Normally, YouTube Videos.

# How?
By simply have a PIP (Picture in Picture) Assistant, I can drop a video on my application (whatever I'd like), 
and make it run while I'm doing stuff. I can resize it, make it transparent, and make it avoid my mouse when 
I place it over the application.

When it is not playing, it will accept an address. It can be a YouTube Address, a File address, or whatever 
Address (I just have to code the correct **integrator** for it).

## What are Integrators?
Is a piece of code used to change the behavior of the video execution. When I have an YouTube Integrator, 
I shall use their API to play videos. When I'm using a File System, I shall use a File System Integrator to see if it is 
a folder or a file, and play it (or them).

### Only 2 Integrators?
That's only the beginning. I don't know if I will need more :man_shrugging:

## Isn't it a little bit overkill?
You might think *"Why not using a regular video player?"* or *"Why not just docking the window?"*.
But this was the main reason I wanted to do this application. none of them allow me to make it transparent-ish
or avoid my mouse pointer if I happen to hover it.

# Features to achieve
I want to achieve the following features in this application (I don't really know if some of them are possible):
- Play video with opacity
- Native dark mode support
- Integration with whatever player mode I want
  - Youtube video lists
  - File Folder
  - Media File
- Fear of Mouse Pointers (The application will avoid the mouse pointer at all costs)
  - Because I might want to use the designed area of the screen, and the companion app would make it impossible, because it is running video


# Final Words 
Not so final, since I'm just beginning this application, it's a little pet project on WPF to help me understand it.

I will change this readme once I have more relevant stuff done
