;; This buffer is for notes you don't want to save, and for Lisp evaluation.
;; If you want to create a file, visit that file with C-x C-f,
;; then enter the text in that file's own buffer.



#JRuby Tutorial:

require 'java'
include_class 'java.util.TreeSet'
set = TreeSet.new
set.add "foo"
set.add "Bar"
set.add "baz"
set.each do |v|
  puts "value: #{v}"
end





