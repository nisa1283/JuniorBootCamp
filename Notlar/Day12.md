# Day 12 - LINQ Advanced

## Bugün Öðrendiklerim

### Join
- Ýki farklý koleksiyondaki iliþkili verileri birleþtirmek için kullanýlýr.
- SQL'deki JOIN mantýðý ile aynýdýr.
- Örneðin Customer ve Order listelerini CustomerId üzerinden birleþtirebiliriz.

### Aggregate Metotlarý

- Sum()      -> Toplam deðeri hesaplar.
- Average()  -> Ortalama deðeri hesaplar.
- Count()    -> Eleman sayýsýný döndürür.
- Max()      -> En büyük deðeri bulur.
- Min()      -> En küçük deðeri bulur.

### First() ve Single()

- First()            -> Ýlk elemaný döndürür.
- FirstOrDefault()   -> Eleman yoksa null/default döndürür.
- Single()           -> Koleksiyonda yalnýzca bir eleman varsa döndürür, aksi halde hata verir.
- SingleOrDefault()  -> Tek eleman veya null/default döndürür.

### Deferred Execution

- LINQ sorgularý hemen çalýþmaz.
- Sorgu, foreach veya ToList() gibi bir metot çaðrýldýðýnda çalýþýr.
- Bu davranýþa Deferred Execution (ertelenmiþ çalýþtýrma) denir.

### ToList() ve ToArray()

- LINQ sorgusunu anýnda çalýþtýrýr.
- Sonucu belleðe alýr.
- Deferred Execution'ý sonlandýrýr.

### Any() ve All()

- Any() -> Koþulu saðlayan en az bir eleman var mý?
- All() -> Bütün elemanlar koþulu saðlýyor mu?

---

## Mini Projede Kullandýklarým

- Join
- Sum
- Average
- Count
- OrderByDescending
- First
- Any
- GroupBy
- LINQ Query Syntax
- LINQ Method Syntax

## Kendime Not

- LINQ, foreach yazmadan koleksiyonlar üzerinde sorgulama yapmamý saðlýyor.
- SQL mantýðýna oldukça benziyor.
- Özellikle Join ve GroupBy metotlarý gerçek projelerde çok kullanýlacak.