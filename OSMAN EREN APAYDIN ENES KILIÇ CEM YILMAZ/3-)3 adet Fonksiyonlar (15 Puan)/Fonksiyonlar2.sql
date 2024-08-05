

-----------------------------------Fonksiyonlar-----------------------------------------------------------------------------------------------------------------------
--Tablo Döndüren Fonksiyonlar (Table-valued Functions)

--Sayısal değerli fonksiyondan tek farkı döndürdüğü verinin tablo olmasıdır.

------------------------------------------------------------------------------------------------------------------------------------------------------------------------



CREATE FUNCTION fn_Fiyatagöresirala (@fiyat int )   --Kitap Fiyatı 20 tl tutarındaki kitapları listelemektedir. 
RETURNS table
AS
RETURN Select KitapAdi,KitapYazari,KitapFiyati from KitapUrun where KitapFiyati=@fiyat
Go


Select * from dbo.fn_Fiyatagöresirala(20)