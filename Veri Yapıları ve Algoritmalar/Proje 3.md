[7, 5, 1, 8, 3, 6, 0, 9, 4, 2] dizisinin Binary-Search-Tree aşamalarını yazınız.

Örnek: root x'dir. root'un sağından y bulunur. Solunda z bulunur vb.

              7
             / \
            5   8
           / \   \
          1   6   9
         / \
        0   3
           / \
          2   4

-root olarak dizinin ilk elamanı olan 7 seçilir.
-5 roottan küçük olduğu için 7'nin sol dalına yazılır.
-1 roottan küçük olduğu için sola bakılır 5' ten de küçük olan 1, 5'in sol dalına yazılır.
-8 roottan büyük olduğu 7'nin sağ dalına yazılır.
-3 roottan küçük olduğu için sola bakılır 5'ten küçük olduğu için sol dalda olan 1 ile karşılaştırılır. 1'den büyük olduğu için 1'in sağ dalına yazılır.
-6 roottan küçük olduğu için 7'nin sol dalına bakılır. 5'ten büyük olduğu için 5'in sağ dalına yazılır.
-0 roottan küçük olduğu için sola bakılır 5'ten küçük olduğu için tekrar sola bakılır 1'den küçük olduğu için 1'in sol dalına yazılır.
-9 roottan büyük olduğu için 7'nin sağ dalına bakılır. 8' den büyük olduğu için 8'in sağ dalına yazılır.
-4 roottan küçük olduğu için sola bakılır. 5'ten küçük olduğu için sola bakılır. 1'den büyük olduğu için sağa bakılır. 3'ten büyük olduğu için sağ dala yazılır.
-2 roottan küçük olduğu için sol dala bakılır. 5'ten küçük olduğu için sola bakılır. 1'den büyük olduğu için sağa bakılır. 3'ten küçük olduğu için sol dala yazılır.