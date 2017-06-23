#! python3
# mcb.pyw - Saves and loads pieces of text to the clipboard.
#--snip--

#  py.exe mcb.py save [keyword] -save current context in clipboard
#  py.exe mcb.py list -list all keys saved before
#  py.exe mcb.py [keyword] -paste the value related with the keyword to clipboard



import shelve, pyperclip, sys

mcbShelf = shelve.open('multiclipboard')

# Save clipboard content.
if len(sys.argv) == 3 and sys.argv[1].lower() == 'save':
           mcbShelf[sys.argv[2]] = pyperclip.paste()
elif len(sys.argv) == 2:
       # List keywords and load content.
    if sys.argv[1].lower() == 'list':
         pyperclip.copy(str(list(mcbShelf.keys())))
    elif sys.argv[1] in mcbShelf:
         pyperclip.copy(mcbShelf[sys.argv[1]])
 
mcbShelf.close()
