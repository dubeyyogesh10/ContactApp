import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ContactDetail } from '../models/contact-detail.model';
import { ContactDetailService } from '../service/contact-detail.service';

@Component({
  selector: 'app-contact-details',
  templateUrl: './contact-details.component.html',
  styleUrls: ['./contact-details.component.css'],
})
export class ContactDetailsComponent implements OnInit {
  constructor(
    public service: ContactDetailService,
    private toast: ToastrService
  ) {}

  selectedContact: ContactDetail;

  ngOnInit(): void {
    this.service.getAllContactDetails();
  }
  onDelete = (id: number) => {
    console.log('Delete clicked - id' + id);
    this.service.deleteContact(id).subscribe(
      (res) => {
        this.service.getAllContactDetails();
        this.toast.warning('Deleted SuccessFully', 'Contact Detailed Deleted');
      },
      (err) => console.log('Error while deleting ' + err)
    );
  };

  populateForm = (contact: ContactDetail) => {
    this.service.formData = Object.assign({}, contact);
  };
}
