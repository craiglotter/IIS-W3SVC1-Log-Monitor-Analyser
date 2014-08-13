IIS W3SVC1 Log Monitor Analyser
===============================

IIS W3SVC1 Log Monitor Analyser is used to extract usable information from the database compiled by the IIS W3SVC1 Log Monitor application. The analyser simply provides a datagrid view of the collected data as well a few computed, user-friendly statistics.

The current format of valid log files (and thus the resulting database) is as follows: (single line, space delimited)
date time s-sitename s-computername s-ip cs-method cs-uri-stem cs-uri-query
s-port cs-username c-ip cs-version cs(User-Agent) cs(Cookie) cs(Referer)
cs-host sc-status sc-substatus sc-win32-status sc-bytes cs-bytes 
time-taken

Created by Craig Lotter, September 2005

*********************************

Project Details:

Coded in Visual Basic .NET using Visual Studio .NET 2003
Implements concepts such as datagrids, data access and SQL.
Level of Complexity: simple
