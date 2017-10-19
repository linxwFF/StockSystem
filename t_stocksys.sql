/*
Navicat MySQL Data Transfer

Source Server         : 127.0.0.1
Source Server Version : 50711
Source Host           : 127.0.0.1:3306
Source Database       : t_stocksys

Target Server Type    : MYSQL
Target Server Version : 50711
File Encoding         : 65001

Date: 2017-10-19 17:45:21
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for t_day_of_stock_info
-- ----------------------------
DROP TABLE IF EXISTS `t_day_of_stock_info`;
CREATE TABLE `t_day_of_stock_info` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `code_name` varchar(255) DEFAULT NULL,
  `today_begin_price` decimal(10,2) DEFAULT NULL,
  `yesterday_end_price` decimal(10,2) DEFAULT NULL,
  `current_price` decimal(10,2) DEFAULT NULL,
  `day_height_price` decimal(10,2) DEFAULT NULL,
  `day_low_price` decimal(10,2) DEFAULT NULL,
  `buy_price` decimal(10,2) DEFAULT NULL,
  `sell_price` decimal(10,2) DEFAULT NULL,
  `number_of_traded_stock` int(11) DEFAULT NULL,
  `deal_price` decimal(10,2) DEFAULT NULL,
  `buy_1` int(11) DEFAULT NULL,
  `buy_1_price` decimal(10,2) DEFAULT NULL,
  `buy_2` int(11) DEFAULT NULL,
  `buy_2_price` decimal(10,2) DEFAULT NULL,
  `buy_3` int(11) DEFAULT NULL,
  `buy_3_price` decimal(10,2) DEFAULT NULL,
  `buy_4` int(11) DEFAULT NULL,
  `buy_4_price` decimal(10,2) DEFAULT NULL,
  `buy_5` int(11) DEFAULT NULL,
  `buy_5_price` decimal(10,2) DEFAULT NULL,
  `sell_1` int(11) DEFAULT NULL,
  `sell_1_price` decimal(10,2) DEFAULT NULL,
  `sell_2` int(11) DEFAULT NULL,
  `sell_2_price` decimal(10,2) DEFAULT NULL,
  `sell_3` int(11) DEFAULT NULL,
  `sell_3_price` decimal(10,2) DEFAULT NULL,
  `sell_4` int(11) DEFAULT NULL,
  `sell_4_price` decimal(10,2) DEFAULT NULL,
  `sell_5` int(11) DEFAULT NULL,
  `sell_5_price` decimal(10,2) DEFAULT NULL,
  `date` varchar(255) DEFAULT NULL,
  `time` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_day_of_stock_info
-- ----------------------------

-- ----------------------------
-- Table structure for t_hold_stock_info
-- ----------------------------
DROP TABLE IF EXISTS `t_hold_stock_info`;
CREATE TABLE `t_hold_stock_info` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `stock_holder_id` int(11) DEFAULT NULL,
  `stock_name` varchar(10) DEFAULT NULL,
  `stock_code` varchar(11) DEFAULT NULL,
  `amount_useable` int(11) DEFAULT NULL,
  `hold_quantity` int(11) DEFAULT NULL,
  `market_price` double DEFAULT NULL,
  `profit_loss` double DEFAULT NULL,
  `profit_loss_per` double DEFAULT NULL,
  `current_price` double DEFAULT NULL,
  `cost_price` double DEFAULT NULL,
  `commission_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_hold_stock_info
-- ----------------------------
INSERT INTO `t_hold_stock_info` VALUES ('1', '1', '东方材料', 'sh603110', '100', '100', '2750', '550', '20', '27.5', '2200', '1');
INSERT INTO `t_hold_stock_info` VALUES ('2', '1', '国芳集团', 'sh601086', '100', '100', '1075', '75', '6.98', '10.75', '1000', '1');
INSERT INTO `t_hold_stock_info` VALUES ('3', '1', '四川长虹', 'sh600839', '100', '100', '390', '-1730', '-443.59', '3.9', '2120', '1');

-- ----------------------------
-- Table structure for t_personal_stock_account
-- ----------------------------
DROP TABLE IF EXISTS `t_personal_stock_account`;
CREATE TABLE `t_personal_stock_account` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `bankroll` double DEFAULT NULL,
  `bankroll_useable` double DEFAULT NULL,
  `bankroll_freezed` double DEFAULT NULL,
  `bankroll_in_cash` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `total_stock` double DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_personal_stock_account
-- ----------------------------
INSERT INTO `t_personal_stock_account` VALUES ('2', '123123.22', '131231.221', '1212312.22', '1241.555', '13.554464', '13.5843');
INSERT INTO `t_personal_stock_account` VALUES ('1', '888.88', '8888888.88', '888888.88', '1241.555', '13.554464', '13.5843');

-- ----------------------------
-- Table structure for t_stock_holder
-- ----------------------------
DROP TABLE IF EXISTS `t_stock_holder`;
CREATE TABLE `t_stock_holder` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `bankroll_id` int(11) DEFAULT NULL,
  `name` varchar(30) DEFAULT NULL,
  `personalID` varchar(50) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `username` varchar(30) DEFAULT NULL,
  `password` varchar(32) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=1223 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_stock_holder
-- ----------------------------
INSERT INTO `t_stock_holder` VALUES ('1', '1', '王耐金', '35033319912312312312', '13774545206', 'admin', 'admin');
INSERT INTO `t_stock_holder` VALUES ('2', '2', '王大锤', '1231231231231352352', '32432423423', 'guest', 'guest');
