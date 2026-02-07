**BÁO CÁO NGẮN (1–2 TRANG): GIẢI THÍCH CÁCH DÙNG PHYSICS TRONG UNITY**

**1. Giới thiệu chung**

Physics trong Unity là hệ thống mô phỏng các quy luật vật lý giúp các đối tượng trong game chuyển động và tương tác một cách tự nhiên. Thông qua Physics, các vật thể có thể rơi do trọng lực, va chạm, trượt, nảy hoặc bị tác động bởi lực. Đây là thành phần quan trọng trong việc xây dựng game 2D và 3D vì nó giúp tăng tính chân thực và tạo cảm giác tương tác tốt hơn cho người chơi.

Trong chương này, sinh viên làm quen với các thành phần cốt lõi của Physics gồm: Collider, Rigidbody, Physics Material, Effector và Character Controller.

---

**2. Collider – Xác định vùng va chạm**

Collider là thành phần giúp Unity nhận biết hình dạng vật thể để phát hiện va chạm. Collider không làm vật thể chuyển động, mà chỉ đóng vai trò như “vùng cảm biến”.

Các loại Collider phổ biến:

* **2D:** BoxCollider2D, CircleCollider2D, PolygonCollider2D
* **3D:** BoxCollider, SphereCollider, CapsuleCollider

Ứng dụng:

* Tường, sàn: dùng BoxCollider
* Nhân vật tròn: dùng Circle/SphereCollider
* Địa hình phức tạp: dùng PolygonCollider

Khi hai Collider chạm nhau, Unity có thể tạo ra:

* **Collision:** va chạm vật lý thật
* **Trigger:** chỉ phát hiện chạm, không đẩy nhau

---

**3. Rigidbody – Tạo chuyển động vật lý**

Rigidbody giúp vật thể chịu tác động của các quy luật vật lý như:

* Trọng lực
* Lực đẩy
* Va chạm

Có 2 loại:

* Rigidbody2D cho game 2D
* Rigidbody cho game 3D

Khi gắn Rigidbody vào object:

* Object có thể rơi xuống đất
* Có thể bị đẩy bằng lực (AddForce)
* Tự động phản ứng khi va chạm

Ví dụ:

* Quả bóng rơi xuống sàn
* Hộp bị đẩy khi va chạm
* Vật thể lăn khi có lực tác động

---

**4. Collision và Trigger**

Unity cung cấp các hàm để xử lý va chạm:

* `OnCollisionEnter()` / `OnCollisionEnter2D()`

  * Xảy ra khi 2 vật thể va chạm thật
  * Có lực đẩy qua lại

* `OnTriggerEnter()` / `OnTriggerEnter2D()`

  * Xảy ra khi đi vào vùng trigger
  * Không có lực vật lý

So sánh:

| Collision               | Trigger                |
| ----------------------- | ---------------------- |
| Có lực đẩy              | Không có lực           |
| Dùng cho tường, sàn     | Dùng cho vùng kiểm tra |
| Nhân vật không đi xuyên | Nhân vật đi xuyên được |

Ứng dụng Trigger:

* Vùng nhặt item
* Cổng dịch chuyển
* Vùng kết thúc màn chơi

---

**5. Physics Material – Điều chỉnh ma sát và độ nảy**

Physics Material cho phép thay đổi cách vật thể phản ứng khi va chạm.

Các thuộc tính chính:

* **Friction (ma sát):** vật trượt nhanh hay chậm
* **Bounciness (độ nảy):** vật bật lên nhiều hay ít

Ví dụ:

* Sàn băng: ma sát thấp → trượt nhiều
* Bóng cao su: bounce cao → nảy mạnh

So sánh khi có và không có Physics Material giúp hiểu rõ ảnh hưởng của ma sát và độ nảy lên chuyển động.

---

**6. Effector 2D – Tạo hiệu ứng đặc biệt**

Effector dùng để tạo các bề mặt có hành vi đặc biệt trong game 2D.

Một số loại phổ biến:

**PlatformEffector2D**

* Tạo sàn một chiều
* Nhân vật có thể nhảy lên từ dưới
* Nhưng đứng được trên mặt sàn

Ứng dụng:

* Platform game (Mario, Hollow Knight)

**SurfaceEffector2D**

* Tạo băng chuyền
* Tự đẩy vật thể theo một hướng

Ứng dụng:

* Nhà máy
* Cơ chế puzzle

---

**7. Rigidbody 3D và AddForce**

Trong môi trường 3D, Rigidbody giúp vật thể:

* Rơi theo trọng lực
* Lăn, trượt
* Bị đẩy bằng lực

Hàm thường dùng:

```
rb.AddForce(Vector3.forward * force);
```

Ứng dụng:

* Đẩy hộp
* Bắn đạn
* Vật thể bị tác động khi va chạm

---

**8. Character Controller – Điều khiển nhân vật**

CharacterController là cách điều khiển nhân vật trong game 3D mà không phụ thuộc hoàn toàn vào Physics.

Ưu điểm:

* Di chuyển mượt
* Leo dốc tốt
* Đi cầu thang ổn định

Các thuộc tính quan trọng:

* **Step Offset:** bước lên bậc thang
* **Slope Limit:** giới hạn độ dốc có thể leo

Các hàm thường dùng:

* `Move()` – điều khiển chính xác
* `SimpleMove()` – di chuyển cơ bản có gravity

---

**9. Ứng dụng tổng hợp trong Mini Project**

Trong scene tổng hợp:

* Player dùng CharacterController để di chuyển
* Vật thể khác dùng Rigidbody để tương tác
* Có platform một chiều và băng chuyền

Mục tiêu:

* Physics hoạt động ổn định
* Va chạm đúng
* Không bị xuyên vật thể

---

**10. Kết luận**

Hệ thống Physics trong Unity đóng vai trò quan trọng trong việc tạo chuyển động và tương tác tự nhiên giữa các vật thể. Qua các bài lab, sinh viên hiểu được:

* Cách dùng Collider để phát hiện va chạm
* Cách dùng Rigidbody để tạo chuyển động vật lý
* Sự khác nhau giữa Collision và Trigger
* Cách điều chỉnh ma sát, độ nảy bằng Physics Material
* Ứng dụng Effector để tạo cơ chế đặc biệt
* Điều khiển nhân vật bằng Character Controller

Việc kết hợp các thành phần này giúp xây dựng các scene game có tính tương tác cao, chuyển động mượt và sát với thực tế hơn.
