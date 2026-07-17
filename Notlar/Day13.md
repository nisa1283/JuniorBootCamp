# Day 13 - Exception Handling

## Bugün Öðrendiklerim

### Exception Nedir?

- Program çalýþýrken oluþan beklenmedik hatalarý temsil eder.
- Kendi exception sýnýflarýmýzý oluþturabiliriz.

### throw

- Exception fýrlatmak için kullanýlýr.

Örnek:

throw new ProductNotFoundException("Product not found.");

---

### try / catch / finally

- try: Hata oluþabilecek kodlar.
- catch: Hata yakalanýr.
- finally: Exception olsa da olmasa da çalýþýr.

finally bloðu genellikle kaynak temizleme iþlemleri için kullanýlýr.

---

### Custom Exception

- Exception sýnýfýndan miras alýnarak oluþturulur.

Örnek:

- OutOfStockException
- ProductNotFoundException

Bu sayede hata mesajlarý daha anlamlý hale gelir.

---

### Exception Yutmak (Boþ Catch Bloðu)

Kötü kullaným:

catch
{
}

- Hatanýn neden oluþtuðunu gizler.
- Debug iþlemlerini zorlaþtýrýr.
- Hatalar en azýndan loglanmalý veya kullanýcýya gösterilmelidir.

---

### Exception Ne Zaman Kullanýlýr?

Exception kullanýlmalý:

- Ürün bulunamadýðýnda.
- Stok yetersiz olduðunda.
- Beklenmeyen durumlarda.

Exception kullanýlmamalý:

- Basit iþ kurallarý ve normal if kontrollerinde.

---

### InnerException

- Bir exception'ýn altýnda baþka bir exception saklamamýzý saðlar.
- Büyük projelerde hata zincirlerini takip etmek için kullanýlýr.

---

## Mini Projede Kullandýklarým

- throw
- try
- catch
- finally
- Custom Exception
- OutOfStockException
- ProductNotFoundException
- List<T>
- FirstOrDefault()
- Any()

## Kendime Not

Exception'lar programýn normal akýþýný kontrol etmek için deðil, olaðan dýþý durumlarý yönetmek için kullanýlmalýdýr.