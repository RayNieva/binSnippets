
line_num=0
File.open('C:/Users/Ray/AppData/Roaming/org/opportunities.org').each do |line|
  print "#{line_num += 1} #{line}"
end
