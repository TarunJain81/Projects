/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import java.io.Serializable;
import javax.faces.bean.ManagedBean;
import javax.faces.bean.SessionScoped;

/**
 *
 * @author Javeed
 */
@ManagedBean
@SessionScoped
public class email implements Serializable {

    public String fromEmailId;
    public String toEmailId;
    public String subject;
    public String dateTime;
    public String content;
    public String status;
    public int id;
    public String type;

    public String getFromEmailId() {
        return fromEmailId;
    }

    public void setFromEmailId(String fromEmailId) {
        this.fromEmailId = fromEmailId;
    }

    public String getToEmailId() {
        return toEmailId;
    }

    public void setToEmailId(String toEmailId) {
        this.toEmailId = toEmailId;
    }

    public String getSubject() {
        return subject;
    }

    public void setSubject(String subject) {
        this.subject = subject;
    }

    public String getDateTime() {
        return dateTime;
    }

    public void setDateTime(String dateTime) {
        this.dateTime = dateTime;
    }

    public String getContent() {
        return content;
    }

    public void setContent(String content) {
        this.content = content;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    
    public email(String fromEmailId, String toEmailId, String subject, String dateTime, String content, String status, int id, String type) {
        this.fromEmailId = fromEmailId;
        this.toEmailId = toEmailId;
        this.subject = subject;
        this.dateTime = dateTime;
        this.content = content;
        this.status = status;
        this.id = id;
        this.type = type;
    }
    
    
    
    
    
    
    
}
