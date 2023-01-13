-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 13 Des 2022 pada 04.10
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `project`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbkelas`
--

CREATE TABLE `tbkelas` (
  `Kode_Kelas` int(5) NOT NULL,
  `Nama_Kelas` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbkelas`
--

INSERT INTO `tbkelas` (`Kode_Kelas`, `Nama_Kelas`) VALUES
(12345, 'TPTU'),
(33333, 'MM');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbsiswa`
--

CREATE TABLE `tbsiswa` (
  `NIS` int(10) NOT NULL,
  `Nama_Siswa` varchar(50) NOT NULL,
  `Jenis_Kelamin` varchar(10) NOT NULL,
  `Tanggal_Lahir` datetime NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `Telpon` varchar(12) NOT NULL,
  `Agama` varchar(10) NOT NULL,
  `Tahun_Masuk` varchar(10) NOT NULL,
  `Kode_Kelas` int(5) NOT NULL,
  `Nama_Kelas` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbsiswa`
--

INSERT INTO `tbsiswa` (`NIS`, `Nama_Siswa`, `Jenis_Kelamin`, `Tanggal_Lahir`, `Alamat`, `Telpon`, `Agama`, `Tahun_Masuk`, `Kode_Kelas`, `Nama_Kelas`) VALUES
(2003060001, 'SITI', 'Perempuan', '2022-11-23 00:00:00', 'KEBON', '098765432123', 'Islam', '2020', 12345, 'TPTU');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbspp`
--

CREATE TABLE `tbspp` (
  `No_Pembayaran` int(10) NOT NULL,
  `SPP_Bulan` varchar(10) NOT NULL,
  `Tanggal_Bayar` datetime NOT NULL,
  `Jumlah` int(20) NOT NULL,
  `NIS` int(10) NOT NULL,
  `Nama_Siswa` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbkelas`
--
ALTER TABLE `tbkelas`
  ADD PRIMARY KEY (`Kode_Kelas`);

--
-- Indeks untuk tabel `tbsiswa`
--
ALTER TABLE `tbsiswa`
  ADD PRIMARY KEY (`NIS`),
  ADD KEY `fk_siswa_kelas` (`Kode_Kelas`);

--
-- Indeks untuk tabel `tbspp`
--
ALTER TABLE `tbspp`
  ADD PRIMARY KEY (`No_Pembayaran`),
  ADD KEY `fk_spp_siswa` (`NIS`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tbkelas`
--
ALTER TABLE `tbkelas`
  MODIFY `Kode_Kelas` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=98767;

--
-- AUTO_INCREMENT untuk tabel `tbsiswa`
--
ALTER TABLE `tbsiswa`
  MODIFY `NIS` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2003060007;

--
-- AUTO_INCREMENT untuk tabel `tbspp`
--
ALTER TABLE `tbspp`
  MODIFY `No_Pembayaran` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2022111603;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbsiswa`
--
ALTER TABLE `tbsiswa`
  ADD CONSTRAINT `tbsiswa_ibfk_1` FOREIGN KEY (`Kode_Kelas`) REFERENCES `tbkelas` (`Kode_Kelas`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `tbspp`
--
ALTER TABLE `tbspp`
  ADD CONSTRAINT `tbspp_ibfk_1` FOREIGN KEY (`NIS`) REFERENCES `tbsiswa` (`NIS`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
