require 'rubygems'
require 'open-uri'
require 'hpricot'

@url = "http://www.igvita.com/blog"
@response = ''

begin
  # open-uri RDoc: http://stdlib.rubyonrails.org/libdoc/open-uri/rdoc/index.html
  open(@url, "User-Agent" => "Ruby/#{RUBY_VERSION}",
    "From" => "email@addr.com",
    "Referer" => "http://www.igvita.com/blog/") { |f|
                  
    puts "Fetched document: #{f.base_uri}"
    puts "\t Content Type: #{f.content_type}\n"
    puts "\t Charset: #{f.charset}\n"
    puts "\t Content-Encoding: #{f.content_encoding}\n"
    puts "\t Last Modified: #{f.last_modified}\n\n"
                
    # Save the response body
    @response = f.read
  }
    
  # HPricot RDoc: http://code.whytheluckystiff.net/hpricot/
  doc = Hpricot(@response)
    
  # Retrive number of comments
  puts (doc/"/html/body/div[3]/div/div/h2").inner_html
      
  # Pull out all quoted text (<blockquote> .... </blockquote>)
  puts (doc/"blockquote/p").first.inner_html
	 
  # Pull out all other posted stories and date posted
  (doc/"/html/body/div[4]/div/div[2]/ul/li/a/span").each do |article|
     puts "#{article.inner_html} :: #{article.next_node.to_s}"
  end
    
rescue Exception => e
  print e, "\n"
end
