# -*- coding: utf-8 -*-
require "c:/users/ray/contacts02-26-14.rb"

#############   Put Data Here ############
=begin
anArray=%w(

raygnieva@rgnterprises.net
Joe\ Blow
1\ Main\ St.
SomeTown
US
99999
999-999-9999
999-999-0000
joeblow@gmail.com
Internet Marketer/Developer/VAR
rgnterprises.net


)
=end



########################################

email=anArray[0]
name=anArray[1]
addr=anArray[2]
town=anArray[3]
state=anArray[4]
zip=anArray[5]
btel=anArray[6]
ptel=anArray[7]
pemail=anArray[8]
title=anArray[9]
company=anArray[10]



aname=Contact.new(email,
name,
addr,
town,
state,
zip,
btel,
ptel,
pemail,
title,
company)

system "cls"
sleep(5)

puts "If using Ditto connect to Clipboard"
gets

puts "Loading Ditto Clipboard Manager Please wait ..."

puts "\n \n"

puts aname.email
sleep(1)

puts aname.name
sleep(1)

puts aname.addr
sleep(1)

puts aname.town
sleep(1)

puts aname.state
sleep(1)

puts aname.zip
sleep(1)

puts aname.btel
sleep(1)

puts aname.ptel
sleep(1)

puts aname.pemail
sleep(1)

puts aname.title
sleep(1)

puts aname.company


puts "Load complete for #{name}..."
puts "Disconnect Ditto from clipboard"
gets

puts "\n"


loop do

puts "COMMANDS for #{name} "
print "(1)- #{email}\n \n"
print "(2)- #{name}  "
print "(3)-first name "
print "(4)-last name\n \n"
print "(5)- #{addr}\n \n "
print "(6)-town: #{town} "
print "(7)-zip: #{zip} \n \n"
print "(8)-btel: #{btel} "
print "(9)-ptel: #{ptel} "
print "(a)-pemail: #{pemail} \n \n "
print "(b)-title: #{title} "
print "(c)-company: #{company} \n \n"
print "x)-EXIT Program \n"





print "Type Number or command: "
gets.chomp
puts case
#when $_.match(/\d/)
when $_.match("1")
       puts aname.email

when $_.match("2")
       puts aname.name

when $_.match("3")
       puts aname.nameStrFirst

when $_.match("4")
       puts aname.nameStrLast

when $_.match("5")
       puts aname.addr

when $_.match("6")
       puts aname.town

when $_.match("7")
       puts aname.zip

when $_.match("8")
       puts aname.btel

when $_.match("9")
       puts aname.ptel

when $_.match("a")
       puts aname.pemail

when $_.match("b")
       puts aname.title

when $_.match("c")
       puts aname.company


   when $_.match(/\d/)
  'String has numbers'
   
   
when $_.match(/[a-zA-Z]/)
  'String has letters'
  #break if $_=="x"
else
  'String has no numbers or letters'
end

puts "\n \n \n"

puts $_
break if $_=="x\n"


end

