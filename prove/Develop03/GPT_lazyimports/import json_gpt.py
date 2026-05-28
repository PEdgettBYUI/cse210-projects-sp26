# Lazily taken from VSCode Chat because it wasn't critical to the code of the project
# Patrick T. Edgett - 5/28/26
# Removed file paths for privacy
import json
import os
import sys

script_dir = os.path.dirname(__file__)
output_path = os.path.join(script_dir, "PoGP-Truncated-lds-scriptures-filtered.json")

# with open(r"c:\....[VALID PATH HERE]....\PoGP-lds-scriptures-filtered.json", encoding="utf-8") as f:
    data = json.load(f)

filtered = [
    {
        "book_title": item.get("book_title"),
        item.get("chapter_number"): [],
        "scripture_text": item.get("scripture_text"),
    }
    for item in data
]

with open(output_path, "w", encoding="utf-8") as f:
    json.dump(filtered, f, ensure_ascii=False, indent=2)

print("\n\nProgram complete")