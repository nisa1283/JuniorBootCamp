# Day 11 - LINQ (Language Integrated Query)

## LINQ Nedir? Ne İşe Yarar?

LINQ (Language Integrated Query), C# içerisinde koleksiyonlar (List, Array vb.) üzerinde sorgulama yapmamızı sağlayan bir yapıdır. Kısacası, veriler üzerinde filtreleme, sıralama, gruplama ve dönüştürme işlemlerini çok daha okunabilir ve kısa bir şekilde yapmamızı sağlar.

LINQ'i, SQL sorgularını C# kodlarının içine taşımak gibi düşünebiliriz.

Örneğin bir öğrenci listemiz olduğunu düşünelim. Notu 70'in üzerinde olan öğrencileri bulmak için normalde foreach döngüsü kullanabiliriz. LINQ sayesinde bunu tek satırda yapabiliriz.

LINQ ile yapabileceğimiz bazı işlemler:

- Veri filtreleme
- Veri sıralama
- Veri gruplama
- Veri dönüştürme
- Veri seçme
- Koleksiyonlar üzerinde sorgulama yapma

LINQ sayesinde daha temiz, okunabilir ve bakımı kolay kodlar yazabiliriz.

---

## Method Syntax ve Query Syntax Arasındaki Fark

LINQ'i iki farklı şekilde kullanabiliriz.

### Method Syntax

En yaygın kullanılan yöntemdir.

```csharp
var result = students.Where(s => s.Grade > 70);
```

Burada Where() metodu kullanılarak notu 70'in üzerinde olan öğrenciler filtrelenmiştir.

---

### Query Syntax

SQL sorgularına daha çok benzer.

```csharp
var result =
from s in students
where s.Grade > 70
select s;
```

Görüldüğü gibi SQL'deki SELECT ve WHERE yapısına oldukça benzemektedir.

---

### Hangisi Daha Çok Kullanılıyor?

Gerçek projelerde Method Syntax çok daha fazla kullanılmaktadır.

Sebepleri:

- Daha kısa olması
- Zincirleme işlemler yapılabilmesi
- Daha esnek olması
- Microsoft dokümantasyonlarında ve topluluk tarafından daha yaygın kullanılması

Bu yüzden LINQ öğrenirken önceliği Method Syntax'a vermek daha mantıklıdır.

---

## Where() Metodu

Bir koleksiyon içerisindeki belirli şartları sağlayan elemanları filtrelemek için kullanılır.

Örnek:

```csharp
var passedStudents = students.Where(s => s.Grade >= 70);
```

Bu örnekte:

- Grade değeri 70 ve üzeri olan öğrenciler seçilir.
- Geriye yeni bir koleksiyon döndürülür.
- Orijinal liste değişmez.

Kullanım amacı:

- Filtreleme işlemleri yapmak.

---

## Select() Metodu

Bir koleksiyon içerisindeki verileri dönüştürmek için kullanılır.

Örnek:

```csharp
var names = students.Select(s => s.Name);
```

Sadece isimleri elde etmiş oluruz.

Başka bir örnek:

```csharp
var upperNames = students.Select(s => s.Name.ToUpper());
```

Tüm isimler büyük harfe çevrilmiş olur.

Kullanım amacı:

- İhtiyacımız olan verileri seçmek.
- Verileri farklı bir formata dönüştürmek.

---

## OrderBy() ve OrderByDescending() Metotları

Verileri sıralamak için kullanılır.

### Küçükten Büyüğe Sıralama

```csharp
var orderedStudents =
students.OrderBy(s => s.Grade);
```

Çıktı:

```
55
70
80
90
95
```

---

### Büyükten Küçüğe Sıralama

```csharp
var orderedStudents =
students.OrderByDescending(s => s.Grade);
```

Çıktı:

```
95
90
80
70
55
```

Kullanım amacı:

- Sayısal verileri sıralamak.
- Alfabetik sıralama yapmak.
- Tarih veya puan gibi değerleri sıralamak.

---

## GroupBy() Metodu

Verileri belirli bir özelliğe göre gruplamak için kullanılır.

Örnek:

```csharp
var groupedStudents =
students.GroupBy(s => s.Department);
```

Eğer elimizde şu veriler varsa:

```
Ali - Yazılım
Ayşe - Yazılım
Mehmet - Elektrik
Zeynep - Elektrik
```

GroupBy sonucunda:

```
Yazılım
- Ali
- Ayşe

Elektrik
- Mehmet
- Zeynep
```

şeklinde gruplanmış olur.

Kullanım amacı:

- Kategorilere ayırma işlemleri.
- Raporlama işlemleri.
- İstatistiksel analizler.

---

## Lambda Expression Nedir?

Lambda Expression, LINQ'in en önemli parçalarından biridir.

Genel kullanım şekli:

```csharp
x => x.Age > 18
```

Bunu Türkçe olarak şöyle okuyabiliriz:

```
"x elemanı için Age değeri 18'den büyük mü?"
```

Başka örnekler:

```csharp
s => s.Name
```

Anlamı:

```
Öğrencinin ismini getir.
```

---

```csharp
s => s.Grade >= 70
```

Anlamı:

```
Notu 70 ve üzeri olan öğrencileri getir.
```

---

```csharp
s => s.Name.ToUpper()
```

Anlamı:

```
Öğrencinin ismini büyük harfe çevir.
```

Lambda ifadeleri LINQ'in okunabilirliğini oldukça artırır.

---

## LINQ'in foreach Döngüsüne Göre Avantajları

### foreach Kullanımı

```csharp
List<Student> passedStudents = new();

foreach(var student in students)
{
    if(student.Grade >= 70)
    {
        passedStudents.Add(student);
    }
}
```

Bu yöntem çalışır ancak kod uzamaya başlar.

---

### LINQ Kullanımı

```csharp
var passedStudents =
students.Where(s => s.Grade >= 70);
```

Aynı işlemi tek satırda yapmış olduk.

---

### LINQ'in Avantajları

- Daha okunabilir kod yazılır.
- Daha kısa kod yazılır.
- Zincirleme işlemler yapılabilir.
- SQL mantığına benzediği için öğrenmesi kolaydır.
- Büyük veri koleksiyonları üzerinde daha kullanışlıdır.
- Kodun bakımını kolaylaştırır.

LINQ "Nasıl yapılacağını" değil "Ne yapılacağını" ifade etmemizi sağlar.

Bu yaklaşıma Declarative Programming (Deklaratif Programlama) denir.

Örneğin:

```
Notu 70'in üzerindeki öğrencileri getir.
```

dememiz yeterlidir. LINQ bunu nasıl yapacağını kendisi halleder.

---

## IEnumerable<T> Nedir?

IEnumerable<T>, LINQ'in temelinde bulunan arayüzdür.

LINQ metotlarının büyük çoğunluğu IEnumerable<T> üzerinde çalışır.

Örneğin:

```csharp
List<Student>
```

aslında IEnumerable<Student> arayüzünü implement eder.

Bu yüzden aşağıdaki işlemler mümkündür:

```csharp
Where()
Select()
OrderBy()
GroupBy()
```

LINQ, IEnumerable sayesinde koleksiyonlar üzerinde dolaşabilir ve sorgulama yapabilir.

Basitçe şöyle düşünebiliriz:

```
List
↓

IEnumerable

↓

LINQ metotları
```

Yani LINQ'in çalışabilmesi için koleksiyonların IEnumerable<T> arayüzünü desteklemesi gerekir.

---

## Özet

- LINQ, C# içerisinde SQL benzeri sorgular yazmamızı sağlar.
- Method Syntax gerçek projelerde daha yaygın kullanılmaktadır.
- Where() filtreleme işlemleri için kullanılır.
- Select() veri dönüştürmek veya belirli alanları seçmek için kullanılır.
- OrderBy() ve OrderByDescending() verileri sıralamak için kullanılır.
- GroupBy() verileri gruplamak için kullanılır.
- Lambda Expression, LINQ sorgularının temel yapı taşıdır.
- LINQ, foreach döngüsüne göre daha okunabilir ve daha kısa kodlar yazmamızı sağlar.
- IEnumerable<T>, LINQ metotlarının üzerinde çalıştığı temel arayüzdür.