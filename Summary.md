#Week 2: Survey Existing Open Source Projects

Author: Brian Liceaga<br>
Course: COMP 412<br>
Date: 6/14/14<br>
<br><br>


###Bluedriving
<p>
Recently, I have been very interested in Bluetooth technology, and I have spent a fair amount of time searching for open source projects.  More specifically, I was looking for a project that was programmed in python.  In browsing through GitHub, I came across the [*Bluedriving*](https://www.github.com/verovaleros/bluedriving/).  If you could not have guessed by the name, *Bluedriving* is a Bluetooth wardriving utility.  The Wikipedia definition of wardriving is "the act of searching for Wi-Fi wireless networks by a person in a moving vehicle, using a portable computer, smart phone or personal digital assistant (PDA)." Essentially, wardriving is a *hacking* term used for reconnaissance. Since security is a major passion of mine, this project got me excited.
</p>

<p>
*Bluedriving* can capture information about Bluetooth devices, look up their services, get GPS information, and present everything in a web page. It can search for and display a fair amount of information about the device, such as the GPS address and the historic location of devices on a map. The main motivation of this tool is to research about the targeted surveillance of people by means of a cellular phone or car. Based on the information you can capture with this tool, it has the ability to display the points where you have seen the same device in the past. Currently, it only runs on Linux.
</p>

<p>
Although *Bluedriving* doesn't have a dedicated website, the GitHub repository contains a wealth of information such as what the product does, the version, features, dependencies, usage, examples, troubleshooting, bugs, and a to-do list.  The to-do list section was a pleasant surprise for me! Most projects I come across lack a to-do list, which adds complexity for contributing. Some of the list items were arbitrary such as "add more types of alarms", while other list items were very specific such as "At the right of each device it can say how many times we found it."  The project has a three contributors, five branches, six forks, and forty-four stars.  The last commit was two months ago, but I can sense that this is an on-going development because of the to-do list.  The to-do list could be considered somewhat of a project management approach that this project is using.  
</p>

<p>
In analyzing the files, the code itself has excellent readability with the appropriate and consistent use of spacing and comments.  While the documentation contained a fair amount of helpful material, I found that it lacked a standards section.  Standards are essential for maintaining consistency, but in this case I have inferred that at least two of the three contributors are friends because of the informality of processes and the language of the documentation.
</p>

<p>
Based on the number of stars and sufficient documentation, the user community has shown interest in this project.  The biggest letdown of this project is the informality, which sets it apart from exemplar open source projects such as abjad. With a major rejuvenation, this project has serious potential to be crowned the bluetooth verison of Netstumbler (Windows), Kismet (Linux), or iStumbler (OS X).
</p>
<br>

###Badges 

<p>
After watching the "What Is A Badge?" video on the FOSSAL YouTube channel, I was inspired to look further into the Mozilla Open Badges project.  The Mozilla community has always done a fine job of producing and maintaining effective open source products such as the widely successfully web browser Firefox, and Open Badges is no exception. Open Badges takes the concept of a digital badge one step further by allowing people to verify their skills, interests, and achievements. This happens through credible organizations which attach that information to the badge image file, hard-coding the metadata for future access and review. Badges can be displayed wherever earners want them on the web, and share them for employment, education or lifelong learning. Upon searching the term *open badges*, I was presented with a dedicated project website, Mozilla wiki page, and social media accounts of the project.  This demonstrations the professionalism, formality, and maturity that most FOSS projects lack. </p>

<p>
The project website, [www.openbadges.org] (http://www.openbadges.org/), is eloquently designed and easy to navigate through with a clear mission statement of creating a new online standard to recognize and verify learning. The [project wiki] (https://wiki.mozilla.org/Badges) expands upon the project background, definition, usablility, and community. The Open Badges GitHub repository is equally impressive and well organized.  Each role regarding involvement with Open Badges is described in the README such as the multiple usages for issuers and developers.  Overall, the documentation is exemplar.
</p>

<p>
Open Badges has been developed in Javascript. For someone who wants to issue a badge, they are able to do so through the Javascript API, which also has its own documentation markdown page.  Although I am not very familiar with Javascript and its syntax, I noticed the neatness of the code as well as comments when I looked through it. Since the initial API platform has been developed, it appears that organizations are using the API for their own internal customized uses and failing to additionally be contributing to the GitHub repository. I made this statement becuase the last commit to the repository was from six months ago; however, you should take this statement with a grain of salt since I am fairly new to the project.    
</p>

<p>
Community support for this project can be seen by the professional demeanor.  Besides the documentation, there are informative YouTube videos as well as other social sites to help publicize the effort. I noticed a "Join our team Jobs" link at the bottom of the website. However, I was disappointed to see that this page did not have any content. Nevertheless, I did some more browsing around, and I found there are active postings on the developer group for the project.  The next step for this project seems to be building out the user community so that more courses to obtain badges are made available.  The project does have a large list of major names issuing and designing open badges including Michigan State University, NYC Department of Education, Carnegie Mellon Robotics Academy, Microsoft, and Disney-Pixar.  I would love to see Loyola University Chicago be added to this list! LUC could play a dual role as a designer and an issuer.  LUC could deploy Open Badges as a social media package that would be used for a number of services including course history, recruiting for clubs, research, and jobs, and as a way to find students who share similar interests.   
</p>
<br>



###Coder (for Raspberry Pi)

<p>
[Coder] (https://googlecreativelab.github.io/coder/) is a open source project by Google that makes web development easy on a Raspberry Pi.  Coder turns your Raspberry Pi into a mini web server that allows for the creation of web content using HTML, CSS and JavaScript via a browser-based IDE.  This out of the box solution is perfect for a classroom environment by encompassing all the elements of web development without the need for large physical servers and the complexity of IDEs. Eliminating the clutter, you are left with a low energy, low cost (RPi is about $35), and highly effective educational solution.    
</p>

<p>
The Coder is its own image that is built on top of Raspbian.  The interface is clean and simple, and you can see the code side by side with the result and change it in real time. The section tabs physically and conceptually separate the HTML from the styles from the script.  
</p>

<p>
The Coder team highly encourages help from the user community and directs users to its [GitHub repository](https://www.github.com/googlecreativelab/coder/). For new users, there is a [Coder Projects](https://googlecreativelab.github.io/coder-projects/) page that lays the foundation for beginners and serves as early lessons for instructors.  These projects are simple so that even users who have never coded before can become acclimated at a comfortable level.  I think of this as killing two birds with one stone so as to learn about web development while additionally covering the basics of a Raspberry Pi device.  Setting up a Coder lab environment, or connecting multiple Coder devices to the same network, requires some manual configuration, but there has been a lab setup guide published to walk users through the steps. The site mentions "We’re working on making this easier... ", which looks to me like a great to place to help out!     
</p>

<p>
The advertised channels of contributing to Coder are bug fixes, respond to feature requests (to make Coder the most accessible way for new coders to learn to make things for the web), create how-to videos, demos and samples to teach and learn (adding to Coder Projects).  Lastly, the project team wishes for its community to support Coder events and to seek classroom teaching opporunities with Coder. I am not very familiar with the Loyola Computer Science department's courses for web based development, but I definately think a course  utilizing Coder could serve as a great introductly course to HTML, CSS, Javascript, and the Raspberry Pi.
</p>

<p>
The project uses a combination of Python, CSS, HTML, and Javascript (also some support files/scripts for the Linux kernel).  The code readability and design are equal to the Google standard of exellence. Its code organization (good architecture and project management from the start), documentation, formal image/brand management, and ease to contribute to make Coder an exemplar FOSS project.   
</p>
