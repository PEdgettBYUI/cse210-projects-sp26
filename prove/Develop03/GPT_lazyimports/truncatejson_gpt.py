import os
import sys
import json
from collections import defaultdict

# load input list of dicts
script_dir = os.path.dirname(__file__)
output_path = os.path.join(script_dir, "DC-Truncated-lds-scriptures-filtered.json")

# with open(r"c:\....[VALID PATH HERE]....\PoGP-lds-scriptures-filtered.json", encoding="utf-8") as f:
    data = json.load(f)

# nested dict: books[book_title][chapter_str] -> list of verses
books = defaultdict(lambda: defaultdict(list))

for item in data:
    book = item.get("book_title")
    chap = item.get("chapter_number")
    verse = item.get("scripture_text")
    if not (book and chap and verse):
        continue
    books[book][str(chap)].append(verse)

# convert defaultdicts to regular dicts and (if you want) sort chapters
output = []
for book_title, chapters in books.items():
    # optional: sort chapter keys numerically
    sorted_chapters = {k: chapters[k] for k in sorted(chapters.keys(), key=int)}
    output.append({book_title: sorted_chapters})

# write output
with open(output_path, "w", encoding="utf-8") as f:
    json.dump(output, f, ensure_ascii=False, indent=2)

print("\n\nProgram Complete")