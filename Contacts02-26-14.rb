

class Contact
#initialize
   @@no_of_contacts=0

   def initialize(email, name, addr,town,state, zip, btel, ptel, pemail,title,company)
      @contact_id=email
      @contact_name=name
      @contact_addr=addr
      @contact_town=town
      @contact_state=state
      @contact_zip=zip
      @contact_btel=btel
      @contact_ptel=ptel
      @contact_pemail=pemail
      @contact_title=title
      @contact_company=company
   end

#Setter Methods:

   def email=(em)
     @contact_id=em
   end

   def name=(nm)
     @contact_name=nm
   end

   def addr=(ad)
     @contact_addr=ad
   end

   def town=(tn)
     @contact_town=tn
   end

   def state=(stat)
     @contact_state=stat
   end

   def zip=(zp)
     @contact_zip=zp
   end

   def btel=(bt)
     @contact_state=bt
   end

   def ptel=(pt)
     @contact_ptel=pt
   end

   def pemail=(pe)
     @contact_pemail=pe
   end

   def title=(ti)
     @contact_title=ti
   end

   def company=(co)
     @contact_company=co
   end



#Getter Methods:
   def email
      puts @contact_id
      @contactEmailString=@contact_id.to_s
      puts `echo #{@contactEmailString} | clip`
   end

   def name
      puts @contact_name
      @contactNameString=@contact_name.to_s
      puts `echo #{@contactNameString} | clip`
   end

   def nameStr
      @contactNameString1=@contact_name.to_s
   end

   def nameStrFirst
      @contactNameString=@contact_name.to_s
      @loc=@contactNameString=~/\s/
      @fname=@contactNameString[0,@loc]
     puts `echo #{@fname} | clip`
   end


   def nameStrLast
      @contactNameString=@contact_name.to_s
      @loc=@contactNameString=~/\s/
      @lname=@contactNameString[@loc+1,@contactNameString.length-(@loc+1)]
      puts `echo #{@lname} | clip`
   end

   def addr
      puts @contact_addr
      @contactAddrString=@contact_addr.to_s
      puts `echo #{@contactAddrString} | clip`
   end
   
   def town
      puts @contact_town
      @contactTownString=@contact_town.to_s
      puts `echo #{@contactTownString} | clip` 
   end
   
   def state
      puts @contact_state
      @contactStateString=@contact_state.to_s
      puts `echo #{@contactStateString} | clip` 
   end

   def zip
      puts @contact_zip
      @contactZipString=@contact_zip.to_s
      puts `echo #{@contactZipString} | clip`
   end

   def btel
      puts @contact_btel 
       @contactBtelString=@contact_btel.to_s
      puts `echo #{@contactBtelString} | clip`
   end

   def ptel
      puts @contact_ptel
      @contactPtelString=@contact_ptel.to_s
      puts `echo #{@contactPtelString} | clip`
    end

   def pemail
      puts @contact_pemail
       @contactPemailString=@contact_pemail.to_s
      puts `echo #{@contactPemailString} | clip`
   end

   def title
      puts @contact_title
       @contactTitleString=@contact_title.to_s
      puts `echo #{@contactTitleString} | clip`
   end

   def company
      puts @contact_company
       @contactCompanyString=@contact_company.to_s
      puts `echo #{@contactCompanyString} | clip`
   end

end




=begin 
ray=Contact.new("ray.nieva@diningalliance.com", #email
"Ray Nieva",#name 
"280 Lincoln St ",#addr
"Allston",#town
"MA ",#state
"01234",#zip
"617-275-8430 x148",#btel
"978-763-5277",#ptel
"raynieva@gmail")#pemail
=end


=begin
aname=Contact.new("", #email
"",#name 
"",#addr
"",#town
"",#state
"",#zip
"",#btel
"",#ptel
"",#pemail
"")#title
=end

 


