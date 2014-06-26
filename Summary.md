#Survey of Three Open Source Network Monitoring Projects

Author: Tianlin Cai<br>
Course: COMP 412<br>
Date: 6/16/2014<br>
<br><br>


###Nagios
<p>
Through searching “network monitoring projects” on google and looking at the results it fed back, I found that [*Nagios*] is the most popular among them. So I took a deeper look at, I found "Nagios is a powerful monitoring system that enables organizations to identify and resolve IT infrastructure problems before they affect critical business processes." The main users of Nagios are individual and small businesses.  
</p>

<p>
Taking a look at the website (http://www.nagios.org/about/overview/), I find the functions of Nagios can be briefly concluded as [Monitoring] IT staff configure Nagios to monitor critical IT infrastructure components, including system metrics, network protocols, applications, services, servers, and network infrastructure. [Alerting] Nagios sends alerts when critical infrastructure components fail and recover, providing administrators with notice of important events. Alerts can be delivered via email, SMS, or custom script. [Response] IT staff can acknowledge alerts and begin resolving outages and investigating security alerts immediately. Alerts can be escalated to different groups if alerts are not acknowledged in a timely manner. [Reporting] Reports provide a historical record of outages, events, notifications, and alert response for later review. Availability reports help ensure your SLAs are being met. [Maintenance] Scheduled downtime prevents alerts during scheduled maintenance and upgrade windows. [Planning] Trending and capacity planning graphs and reports allow you to identify necessary infrastructure upgrades before failures occur.
</p>

<p>
The newest version is Nagios XI, which is not free and can be bought online. I didnt find certain entire FOSS version on the website directly, but one of Nagios (5.3.4) on Github (https://github.com/tas50/nagios#time-periods).
</p>

<p>
The language of this version on Github is Ruby, while that of the official version is C. In analyzing the files, the code of Nagios (5.3.4) has excellent readability and maintainability. It has very entire and complete documentation, from almost every aspects to let readers know about it. Most of its documentation is of online form. (http://www.nagios.org/documentation)
</p>

<p>
There are many links on the website to tell people they are welcome to join in this project. Like "Forum", "Get involved" and "Projects". The entire project is separated to several parts and I think it is easier for people to find their target.
</p>
<br>

###OpenNMS

<p>
OpenNMS is the world’s first enterprise grade network management application platform developed under the open source model. It started in July of 1999, designed to meet the demand of enterprises and carries, has a highly customizable management solution and it is 100% FOSS.
</p>

<p>
After reading the overview of the functions, I conclude them as [Discovery] Set OpenNMS at the network and it will discover the network services running. [Notification] OpenNMS can both send and receive events, work as main repository for the network event stream and generate tickets when critical events happen. [Service] Service Level Agreements (SLAs) work on management effort and perform transactions from many kinds of monitoring events. [Measurement] SNMP and JMX protocols are the main data collectors in OpenNMS. All data stored can be tested by thresholds and be graphed.
</p>

<p>
You can get open source code of OpenNMS on its website or find it on github (https://github.com/OpenNMS/opennms). The stable version is 1.12, the unstable version is 1.13. It seems more people are contributing their efforts on 1.13 to make it stable to work.
</p>

<p>
The main language of OpenNMS is Java. After checking a random file, I confirm it has excellent readability and maintainability. It has very entire and complete documentation, from every aspects to let readers know about it. Most of its documentation is of online form (http://www.opennms.org/wiki/Docu-overview). There is also a hardcover book of German version.
</p>

<p>
People who want to contribute to this project are totally welcome. You can find almost every kind of support on the wiki page. Things are listed as details there.
</p>
<br>



###Zenoss

<p>
Zenoss was founded in 2005 to address the challenges of operating and assuring large-scale IT services. The key principles that drove their initial offerings are even more relevant today as organizations drive towards the vision of automated operations and hybrid cloud infrastructure.
</p>

<p>
Features include automatic discovery, inventory via CMDB, availability monitoring, easy-to-read performance graphs, sophisticated alerting, an easy-to-use web portal, and much, much more.
</p>

<p>
Only the Zenoss core can be downloaded at the official website, and only some partial modules can be found at github. Most of them use Python as language, so it has excellent readability and maintainability. The documentation is partial and not very detailed.
</p>

<p>
It seems Zenoss becomes much more commercialized than it was at the beginning. They set many paid positions but not have much care of public participation. So the possibility of taking an overview of the source code of it and getting involved in the development of it is small.
</p>

