# csharp-process-manager
Aplikasi untuk Memanage process di C#

Karena ada keperluan ingin meng-hidden sebuah program agar tidak mengganggu ketika gw lagi pake Windows, akhirnya gw melakukan riset kecil-kecilan tentang bagaimana membuat process yang berjalan menjadi hidden di C#. Tidak serumit itu, dan tidak perlu library eksternal untuk membuat aplikasi ini. C# sudah memiliki namespace System.Diagnostics yang fitur-nya udah sangat lengkap.

Adapun untuk hak akses, agar bisa mendapatkan informasi lokasi file dari process yang dipilih, aplikasi ini membutuhkan akses "Administrator". Agar aplikasi ini selalu meminta akses sebagai administrator ketika dibuka, gw memanfaatkan konfigurasi app.manifest, bisa cek di dalamnya seperti apa konfigurasinya.

# Fitur
1. Melihat list process yang berjalan
2. Hide Process yang dipilih di dalam list
3. Show Process yang dipilih di dalam list (unfixed)
4. Kill Process yang dipilih di dalam list
5. Melihat FileLocation di dalam list

# Issue
Setelah menghidden process, process-nya tidak bisa ditampilkan kembali.
*Yang mau kasih masukkan silahkan, mungkin nanti akan gw riset lagi untuk memperbaiki issue saat ini

Untuk beberapa process, akan mengalami error seperti ini:
A 32 bit processes cannot access modules of a 64 bit process
*Gw belum research lagi bagaimana cara memperbaiki error ini



