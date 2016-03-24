require 'rubygems'
require 'open-uri'
require 'hpricot'

@url = "https://www.igvita.com"
#@url = https://www.igvita.com/2007/02/04/ruby-screen-scraper-in-60-seconds/
@response = ''

# open-uri RDoc: http://stdlib.rubyonrails.org/libdoc/open-uri/rdoc/index.html
open(@url, "User-Agent" => "Ruby/#{RUBY_VERSION}",
    "From" => "email@addr.com",
    "Referer" => "https://www.igvita.com/") { |f|
    puts "Fetched document: #{f.base_uri}"
    puts "\t Content Type: #{f.content_type}\n"
    puts "\t Charset: #{f.charset}\n"
    puts "\t Content-Encoding: #{f.content_encoding}\n"
    puts "\t Last Modified: #{f.last_modified}\n\n"

    # Save the response body
    @response = f.read

}

#Rdoc: http://code.whytheluckystiff.net/hpricot/
doc = Hpricot(@response)

# Retrive number of comments
#  - Hover your mouse over the 'X Comments' heading at the end of this article
#  - Copy the XPath and confirm that it's the same as shown below
puts (doc/"/html/body/div/div[1]/div[1]/blockquote[2]").inner_html
#/html/body/div/div[1]/div[1]/blockquote[2]

# Pull out first quote (<blockquote> .... </blockquote>)
# - Note that we don't have to use the full XPath, we can simply search for all quotes
# - Because this function can return more than one element, we will only look at 'first'
puts (doc/"blockquote[2]/p").first.inner_html

