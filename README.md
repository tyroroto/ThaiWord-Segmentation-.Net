# ThaiWord-Segmentation-.Net
Dictionary Text segmentation
## How to use
```
using THSplit;
 public void TestSplit1()
        {
            Spliter spliter = new Spliter();
            string test = "นายจะไปไหนหรอ";
            var output = spliter.SegmentByDictionary(test);
            //output is List<string>
        }
```
## Base on PHP THSplitlib
https://github.com/moohooooo/thsplitlib
