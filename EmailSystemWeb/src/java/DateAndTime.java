/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;

/**
 *
 * @author phani
 */
public class DateAndTime {

    //a format string for the date and time
    public static final String DATE_FORMAT_NOW = "MMM-dd-yyyy HH:mm:ss";
    public static String dt;

    //get the date and time now

    public static String DateAndTime() {
        Calendar cal = Calendar.getInstance();
        SimpleDateFormat sdf = new SimpleDateFormat(DATE_FORMAT_NOW);
        return sdf.format(cal.getTime());
    }

}
